
#ifndef __UTITLITY__
#define __UTITLITY__


//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Safe deletion of pointers
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
template <class T> T* delete_ptr (T *&ptr) {
	if (ptr != NULL) {
		delete ptr;
		ptr = NULL;
	}
	return ptr;
}

//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Safe deletion of arrays
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
template <class T> T* delete_array (T *&ptr) {
	if (ptr != NULL) {
		delete []ptr;
		ptr = NULL;
	}
	return ptr;
}

//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Max
// Compares two values. Returns the largest.
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
template <class T> T Max (T a, T b) {
	return (a > b ? a : b);
}

//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Min
// Returns the smallest of two values
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
template <class T> T Min(T a, T b) {
	return (a > b ? b : a);
}

//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
// Abs
// Returns the absolute of a numeric type
//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
template <class T> T Abs (T a) {
	return (a > 0 ? a : -a);
}


#endif //__UTITLITY__