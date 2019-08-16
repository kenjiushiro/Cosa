import pandas as pd
def encrypt(message,key):
    newMessage =""        
    pos = 0
    alphabet = "abcdefghijklmnñopqrstuvwxyz"
    
    for letra in message:
        pos = alphabet.find(letra)
        if pos != -1:
            if pos+key >= len(alphabet):
                pos = pos - len(alphabet)
            newMessage = newMessage + alphabet[pos+key]
        else:
            newMessage = newMessage + letra        
    return newMessage

def deencrypt(message,key):
    return encrypt(message,-key)
    
option = int(input("1 - Encriptar\n2 - Desencriptar\n"))

if (option==1):
    mensaje = input("Encriptar: ")
    code = int(input("Codificacion: "))
    
    encriptado = encrypt(mensaje,code)
    print(encriptado)
    salir = input("Salir")

    df=pd.DataFrame([encriptado])
    df.to_clipboard(index=False,header=False)
elif (option == 2 ):
    mensaje = input("Desencriptar: ")
    code = int(input("Codificacion: "))
    
    print(deencrypt(mensaje,code))
    


