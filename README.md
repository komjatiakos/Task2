# Task2

Nem tudtam importálni az sql fájlt. Nem tudom miért. 
Szétnéztem a stackoverflow-on és ott találtam annyit,
hogy ezeket a sorokat:
-> ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
cseréljem erre:
-> ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;
Sajnos ez sem segített(pedig commentek nélkül amit az sql generált kommentekkel m
indenhogy próbálkoztam el is pacsáltam vagy 2 órát vele), ezért csak egy szerény Random szám generálót
sikerült össze hozni. 