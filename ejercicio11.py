def evaluar_polinomio_pares(coeficientes, x):
    """
    Evalúa un polinomio en x considerando solo los coeficientes pares.
    :param coeficientes: Lista de coeficientes del polinomio desde el término de mayor grado hasta el término independiente.
    :param x: Valor en el cual se evaluará el polinomio.
    :return: Resultado de la evaluación del polinomio.
    """
    resultado = 0
    grado = len(coeficientes) - 1
    
    for i, coef in enumerate(coeficientes):
        if coef % 2 == 0:  # Solo considerar coeficientes pares
            resultado += coef * (x ** (grado - i))
    
    return resultado

# Ejemplo de uso:
coeficientes = [4, 3, 2, 6, 5]  # Representa 4x^4 + 3x^3 + 2x^2 + 6x + 5, siguiendo a P(x)
x = 2
resultado = evaluar_polinomio_pares(coeficientes, x)
print("Resultado del polinomio con coeficientes pares en x=", x, "es:", resultado)

