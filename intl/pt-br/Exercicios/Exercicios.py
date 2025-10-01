import os

# 1 - Crie uma lista para cada informação a seguir:

def questao1():
    #Lista de números de 1 a 10
    numeros = []
    for i in range(1,11):
        numeros.append(i)

    print(numeros)

    # Lista com quatro nomes;
    nomes = []
    nomes.append("Abel")
    nomes.append("João")
    nomes.append("Maria")
    nomes.append("Gabriel")

    print(nomes)
# 2 - Utilize um loop for para calcular a soma dos números ímpares de 1 a 10.
def questao2():
    soma = 0

    for numero in range(1, 11):
      if numero % 2 != 0:
        soma += numero

    print("A soma dos números ímpares de 1 a 10 é:", soma)

# 3 - Utilize um loop for para imprimir os números de 1 a 10 em ordem decrescente.
def questao3():
   for numero in range(10, 0, -1):
    print(numero, end=" ")
   
# 4 - Solicite ao usuário um número e, em seguida, utilize um loop for para imprimir a tabuada desse número, indo de 1 a 10.
def questao4():
   numero_usuario = int(input("Digite o número para saber a tabuada: "))
   for numero in range(1, 11):
    print(f"{numero_usuario} * {numero} = {numero_usuario * numero}")

def main():
    questao1()
    questao2()
    questao3()
    questao4()

if __name__ == '__main__':
    main()