#include <iostream>
#include <climits>

#define pause std::cin.get();
#define print(x) std::cout << x << std::endl;
#define print2(x,y) std ::cout << x << y << std::endl;


using namespace std;

int main(){

	print2("Max of Integer ", INT_MAX);
	print2("Min of Integer ", INT_MIN);
	print2("Max of Unsigned Integer ", UINT_MAX);
	print2("Max of Long Long ", LLONG_MAX);
	print2("Min of Long Long ", LLONG_MIN);
	print2("Max of Unsigned Long Long ", ULLONG_MAX);
	print2("The bits contained in a char ", CHAR_BIT);
	print2("Max of char ", CHAR_MAX);
	print2("Min of Char ", CHAR_MIN);
	print2("", SCHAR_MAX);
	print2("", SCHAR_MIN);
	print2("", UCHAR_MAX);
	print2("", SHRT_MAX);
	print2("", SHRT_MIN);
	print2("", USHRT_MAX);

	print2("Size of int ", sizeof(int));
	print2("Size of ", sizeof(char));
	print2("Size of short ", sizeof(short));
	print2("Size of long long", sizeof(long long));
	print2("Size of unsigned Long long ", sizeof(unsigned long long));


	pause

	return 0;
}