#include "vector";

#pragma once
class CollatzProblem
{
public:
   void CollatzProblemFunc(int nStartNumber, std::vector<int>& vnNumbers);
private:
    int NumberIsOdd(int nNumber);
    int NumberIsEven(int nNumber);
    bool CheckForEscapeSequenz(int nNumber);
};

