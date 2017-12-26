#include <iostream>

using namespace std;

int main(int argc, char **argv){
    int test = 19;
    
    cout << "Hello World" << "\n";
    cout << test << "\n";

    for (int i = 1; i < argc; ++i)
        cout << argv[i] << "\n";
    cout << "GoodBye" << "\n";
    return 0;
}