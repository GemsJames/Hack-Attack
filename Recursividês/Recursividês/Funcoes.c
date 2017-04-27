int Factorio(int x) {
	if (x = 0)
		x = 1;
	else
		x *= Factorio(x - 1);
	return x;
}

int Potencia(int x, int y) {
	if (y = 0)
		x = 1;
	else
		x = x * Potencia(x, y - 1);
	return x;
}

int Fibonacio(int x) {
	if (x <= 1)
		x = 1;
	else
		x = Fibonacio(x - 1) + Fibonacio(x - 2);
	return x;
}

int Encontra(int *x, int y, int z) {
	if (z == 0)
		return(-1);
	if (x[z] == y)
		return(z);
	return(Encontra(x, y, z--));
}

