from Alpha import Langs

def Encrypte(text, key, lang):
    if not IsPrimary(int(key), Langs[lang].count):
        return ""
    return Langs[lang][2]


def IsPrimary(a, b):
    while a and b:
        if a > b:
            a = a % b
        else:
            b = b % a
    return a+b==1
