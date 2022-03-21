from Alpha import Langs

def Encrypte(text, key, lang):
  lang = Langs[lang]
  result = ""
  t_size = len(text) // len(key) + 3
  table = []
  table.append(key)
  for _ in range(t_size-1):
    table.append([None]*len(key))

  count = 1
  for i in lang:
    beg = 0 
    pos = key.find(i, beg)
    while pos != -1:
      table[1][pos] = count
      count+=1
      beg=pos+1
      pos = key.find(i, beg)


  for i, symb in enumerate(text):
    col_num = i//len(key)+2
    table[col_num][i%len(key)]=symb
  for i in range(1,len(key)+1):
    pos = 0
    for j, hui in enumerate(table[1]):
        if(hui==i):
            pos = j
    for lst in table[2:]:
      if(lst[pos]):
        result+=lst[pos]

  return result  
    
def Decrypte(text, key, lang):
  lang = Langs[lang]
  result = ""
  t_size = len(text) // len(key) + 3
  table = []
  table.append(key)
  for _ in range(t_size-1):
    table.append([None]*len(key))

  count = 1
  for i in lang:
    beg = 0 
    pos = key.find(i, beg)
    while pos != -1:
      table[1][pos] = count
      count+=1
      beg=pos+1
      pos = key.find(i, beg)

  k = len(text)%len(key)-1    
  pos_text = 0

  for i in range(1, len(key)+1):
    pos = 0
    for j,hui in enumerate(table[1]):
        if(hui==i):
          pos = j
    for j in range(2,t_size-max(min(pos-k, 1), 0)):
      table[j][pos]=text[pos_text]
      pos_text+=1

  for i in table[2:]:
    for j in i:
      if(j):
        result+=j

  return result