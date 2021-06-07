#include <iostream>
#include <fstream>
#include <sstream>
#include "Windows.h"
#include "ShellAPI.h"

using namespace std;

string path1 = "input.txt";
string path2 = "output.txt";
int const n = 10;
int arr[n];
int k;

void arrayinput() {
    ofstream inputfile;
    inputfile.open(path1);
    for (int i=1; i <= n; i++) {
        cout << "Введите число массива " << i << ": ";
        cin >> arr[i];
        inputfile << arr[i] << " ";
    }
    inputfile.close();
}

void arrayoutput() {
    stringstream numberline;
    char c;
    int num;
    ifstream inputfile(path1);
    ofstream outputfile(path2);
    while(inputfile.get(c)){
    if (c!=' ') {
        numberline << c;
    }
    if (c==' ') {
        numberline >> num;
        if (num%k!=0)
        outputfile << num << " ";
        num = 0;
        numberline.clear();
    }
}
inputfile.close();
outputfile.close();
}



int main() {
setlocale(LC_ALL, "ru");
cout << "Задайте значение K: ";
cin >> k;
arrayinput();
arrayoutput();
ShellExecute(0, L"print", L"output.txt", NULL, NULL, SW_NORMAL);
system("pause");
return 0;
}