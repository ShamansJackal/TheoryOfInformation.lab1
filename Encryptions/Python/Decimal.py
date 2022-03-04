from Alpha import Langs

def Encrypte(text, key, lang):
    key = int(key)
    lang = Langs[lang]
    if not IsPrimary(int(key), len(lang)):
        return ""
    result = ""
    for i in text:
        id = "".join(lang).index(i)
        id = id*key % len(lang)
        result += lang[id]
    print(result)
    return result
    
def Decrypte(text, key, lang):
    key = int(key)
    lang = Langs[lang]
    if not IsPrimary(int(key), len(lang)):
        return ""
    result = ""
    key = SideModuleNumber(key, len(lang))
    for i in text:
        id = "".join(lang).index(i)
        print(id)
        id = id*key % len(lang)
        result += lang[id]
    return result

def SideModuleNumber(a, m):
    def gcdExtended(a, b):
        if a == 0 :
            return b,0,1
        gcd,x1,y1 = gcdExtended(b%a, a)
        x = y1 - (b//a) * x1
        y = x1
        return gcd,x,y
    
    gcd, x, y = gcdExtended(a, m)
    if gcd == 1:
        return (x % m + m) % m
    else:
        raise TypeError()

def IsPrimary(a, b):
    while a and b:
        if a > b:
            a = a % b
        else:
            b = b % a
    return a+b==1
    
print(Decrypte(Encrypte("текст", 2, "RU"),2,"RU"))