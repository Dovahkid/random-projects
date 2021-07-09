#include <iostream>
#include <climits>

using namespace std;

int main()
{
	float fltAmount = 0;
	int intAmount = 0;
	int coinTotal = 0;
	int coinAmounts[] = {0,0,0,0};
	
	const double coins[] = {25, 10, 5, 1};
	const int coinsLength = sizeof(coins)/sizeof(*coins);
	
	bool cont = true;
	char input = CHAR_MAX;

	while(cont)
	{
		intAmount = 0;
		fltAmount = 0;
		fill(begin(coinAmounts), end(coinAmounts), 0);
		coinTotal = 0;

		cout << "How much money do you have?" << endl;
		cin >> fltAmount;

		intAmount = (int) (fltAmount * 100);

		delete &fltAmount;

		for(int i = 0; i < coinsLength; i++)
		{
			while(intAmount >= coins[i])
			{
				intAmount -= coins[i];
				coinAmounts[i] += 1;
				coinTotal += 1;
			}
		}

		cout << "Quarters:\t" << coinAmounts[0] << endl;
		cout << "Dimes:\t" << coinAmounts[1] << endl;
		cout << "Nickels:\t" << coinAmounts[2] << endl;
		cout << "Pennies:\t" << coinAmounts[3] << endl;
		cout << "Total Coins:\t" << coinTotal << endl;

		cout << "Do you want to enter another value? (Y/N)" << endl;
		cin >> input;
		cont = (input == 'N' || input == 'n') ? false : true;

	}
	
	return 0;
}
