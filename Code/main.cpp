#include <iostream>

bool CheckForEscapeSequenz(int nNumber)
{
    bool bResult = false;

    switch (nNumber) {
        case 1:
            bResult = true;
            break;
        case 2:
            bResult = true;
            break;
        case 4:
            bResult = true;
            break;
    }

    return bResult;
}

int NumberIsEven(int nNumber)
{
    return nNumber / 2;
}

int NumberIsOdd(int nNumber)
{
    nNumber = 3 * nNumber;
    nNumber = nNumber+1;
    return nNumber;
}

void Out(const char string[])
{
    std::cout << string << std::endl;
}

void Out(int nNumber)
{
    std::cout << nNumber << std::endl;
}

int Setup()
{
    int nStartNumber;

    Out("Mit welcher Zahl möchstest du starten?");
    std::cin >> nStartNumber;

    return nStartNumber;
}

int main()
{
    Out("Collatz-Problem by Reduzer");
    int nStartNumber = Setup();

    std::cout << "Start bei: " << nStartNumber << std::endl;

    bool bDone = false;

    while (!bDone) {
        if (nStartNumber % 2 == 0) {
            nStartNumber = NumberIsEven(nStartNumber);
        } else {
            nStartNumber = NumberIsOdd(nStartNumber);
        }

        Out(nStartNumber);

        bDone = CheckForEscapeSequenz(nStartNumber);
    }

    Out("Unendliche Folge von: 4 2 1");

    return 0;
}