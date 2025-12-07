#include "vector"

#pragma once
class CollatzProblem
{
public:
   std::vector<int> CollatzProblemFunc(int nStartNumber);
private:
    int NumberIsOdd(int nNumber);
    int NumberIsEven(int nNumber);
    bool CheckForEscapeSequenz(int nNumber);
};

