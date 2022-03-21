from Alpha import Langs
  
def Encrypte(text, key, lang):
	lang = Langs[lang]
	result = ""
	for i, symb in enumerate(text):
		shift = i//len(key)
		keySymb = key[i % len(key)]
		K_i = (lang.index(keySymb) + shift) % len(lang)
		M_i = lang.index(symb)
		result += lang[(K_i+M_i) % len(lang)]
	return result	
    
def Decrypte(text, key, lang):
  lang = Langs[lang]
  result = ""
  for i, symb in enumerate(text):
    shift = i//len(key)
    keySymb = key[i % len(key)]
    K_i = (lang.index(keySymb) + shift) % len(lang)
    C_i = lang.index(symb)
    result += lang[(C_i-K_i) % len(lang)]
  return result