#include "pch.h"

#include <iostream>
#include <string>

using namespace std;

int main() {

	const int loserPoints = 1;
	int adventurers, killed, survived;
	string leader;

	//get information
	cout << "Welcome to Lost Fortune\n\n" << endl;
	cout << "Please enter the following information..." << endl;

	cout << "Enter a number" << endl;
	cin >> adventurers;

	do {
		cout << "Enter a number smaller than the former" << endl;
		cin >> killed;
	} while (killed >= adventurers);

	survived = adventurers - killed;

	cout << "Enter your name" << endl;
	cin >> leader;

	system("CLS");
	cout << "A group consisting of " << adventurers << " losers set out on a quest.\n"<< endl;
	cout << "The group was lead by the biggest loser of them all... " << leader << "\n" << endl;
	cout << "Their quest started in the dank caverns of their parents basement in hopes of finding treasure.\n" << endl;
	cout << "They were such big losers that " << killed << " died on the first flight of stairs.\n" << endl;
	cout << "That left only " << survived << " remaining member(s) of the loser brigade.\n" << endl;
	cout << "The trials and tribulations were worth it in the end, they found " << (loserPoints + leader.length()) * 100 << " fedoras and fake samurai swords\n" << endl;
	cout << "Though the greatest prize may have been their unhealthy collection of \n"
		<<"nude anime girl body pillows awaiting their return in their room." << endl;

	cin.get();
	cin.get();

	return 0;
}
