#include <iostream>;
#include <string>
using namespace std;

int main() {
	cout << "Enter your favorite language\n";
	string language;
	getline(cin, language);
	
	if (language == "Visual C++" || language == "VC++") {
		cout << "We have a winner!\n";
	}else{
		cout << language << " is not a bad language.\n";
	}

	system("pause");

	return 0;
}