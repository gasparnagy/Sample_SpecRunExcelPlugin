#language: hu-HU

@gherkin-hu
Jellemzõ: Adószámítás (Gherkin)

Forgatókönyv: Munkavállaló gyerekek nélkül
	Amennyiben a munkavállaló havi bruttó bére 200000 Ft
	És a családban nincsenek gyerekek
	Amikor az adó kiszámításra kerül
	Akkor nettó bérként 131000 Ft-ot kell kapjunk


Forgatókönyv vázlat: Munkavállaló gyerekek nélkül (SO)
	Amennyiben a munkavállaló havi bruttó bére <bruttó> Ft
	És a családban nincsenek gyerekek
	Amikor az adó kiszámításra kerül
	Akkor nettó bérként <nettó> Ft-ot kell kapjunk

Példák: 
	| bruttó | nettó  |
	| 100000 | 65500  |
	| 200000 | 131000 |
	| 300000 | 196500 |

Forgatókönyv vázlat: Munkavállaló gyerekekkel - részletes
	Amennyiben a munkavállaló havi bruttó bére <bruttó> Ft
	És a családban nincsenek gyerekek
	Amikor az adó kiszámításra kerül
	Akkor nettó bérként <nettó> Ft-ot kell kapjunk
	És az alábbi költségetet kell fizetnie a munkavállalónak
		| Járulékok   | SZJA   |
		| <járulékok> | <szja> |

Példák: 
	| bruttó | nettó  | járulékok | szja  |
	| 100000 | 65500  | 18000     | 16000 |
	| 200000 | 131000 | 37000     | 32000 |
	| 300000 | 196500 | 55500     | 48000 |

