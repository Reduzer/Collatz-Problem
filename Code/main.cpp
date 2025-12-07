#include <iostream>
#include "vector"
#include "CollatzProblem.h"

int main()
{
    CollatzProblem oProb;
    std::vector<int> vnTest;

    vnTest = oProb.CollatzProblemFunc(5);

    for(int i : vnTest){
        std::cout << "c" << std::endl;
    }

    return 0;
}