#include "CollatzProblem.h"

bool CollatzProblem::CheckForEscapeSequenz(int nNumber)
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

int CollatzProblem::NumberIsEven(int nNumber)
{
    return nNumber / 2;
}

int CollatzProblem::NumberIsOdd(int nNumber)
{
    nNumber = 3 * nNumber;
    nNumber = nNumber+1;
    return nNumber;
}

void CollatzProblem::CollatzProblemFunc(int nStartNumber, std::vector<int>& vnNumbers)
{
    bool bDone = false;

    bDone = CheckForEscapeSequenz(nStartNumber);

    while (!bDone) {
        vnNumbers.push_back(nStartNumber);
        if (nStartNumber % 2 == 0) {
            nStartNumber = NumberIsEven(nStartNumber);
        } else {
            nStartNumber = NumberIsOdd(nStartNumber);
        }

        bDone = CheckForEscapeSequenz(nStartNumber);
    }

    vnNumbers.push_back(4);
    vnNumbers.push_back(2);
    vnNumbers.push_back(1);
    return;
}

