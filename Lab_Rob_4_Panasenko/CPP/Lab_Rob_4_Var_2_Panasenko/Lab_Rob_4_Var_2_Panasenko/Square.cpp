#include "Header.h"

Square operator / (Square K1, Square K2)
{
	Square NewK = Square(K1.dot1[0], K1.dot1[1], K1.dot2[0] / K2.dot2[0], K1.dot2[1], K1.dot3[0] / K2.dot3[0], K1.dot3[1] / K2.dot3[1], K1.dot4[0], K1.dot4[1] / K1.dot4[1]);
	return NewK;
}

Square operator + (Square K1, int a)
{
	Square NewK = Square(K1.dot1[0], K1.dot1[1], K1.dot2[0] + a, K1.dot2[1], K1.dot3[0] + a, K1.dot3[1] + a, K1.dot4[0], K1.dot4[1] + a);
	return NewK;
}