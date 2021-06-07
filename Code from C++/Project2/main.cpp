#include <iostream>
#include <fstream>

using namespace std;

string path = "File.txt";
int const n = 10;
int mass[n];
int result;

void arrayt() {
	for (int i = 1; i <= n; i++) {
		cout << "Введите массив " << i << ": ";
		cin >> mass[i];
	}
}

void arrayout() {
	ofstream outfile;
	outfile.open(path);
	for (int i = 1; i <= n; i++) {
		outfile << mass[i] << " ";
	}
	outfile << endl;
	result = mass[1] - mass[n];
	outfile << "Разница первого и последнего числа: " << result;
	outfile.close();
}

int main() {
	setlocale(LC_ALL, "ru");
	arrayt();
	arrayout();
	system("pause");
	return 0;
}
