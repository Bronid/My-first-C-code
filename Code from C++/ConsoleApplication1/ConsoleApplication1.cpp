#include <iostream>

using namespace std;

int main()
{
	int numbers[20], count, result;
	
	for (int B; B <= 20; B++) {
		cout << "Введите число " << B << endl;
		cin >> numbers[B];
	}

	for (int K; K <= 20; K++) {
		if (numbers[K] / 2 == 0) {
			result = result + numbers[K];
			count++;
		}
	}

	cout << "Сума чисел " << count << endl;
}