#include "inout.h"
#include <iostream>
using namespace std;

void read(std::vector<int>& vec) {
    int n;
    std::cin >> n;
    for (int i = 0; i < n; i++) {
        int x;
        std::cin >> x;
        vec.push_back(x);
    }
}