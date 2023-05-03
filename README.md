#longSlice

LongSlice, e' un algoritmo che data una stringa e una sottostringa contigua di lunghezza X, riesce a calcolare il prodotto massimo.

**Ad esempio:**

- data in ingresso la stringa "1027839564", 
- il prodotto più grande per una serie di 3 cifre è 270 (9 * 5 * 6)
- e il prodotto più grande per una serie di 5 cifre è 7560 (7 * 8 * 3 * 9 * 5).

## Descrizione del codice

<details>

<summary> Controlli del codice</summary>
All'interno del codice sono presenti dei controlli:

```c#
if (span > digits.Length || span < 0)
    throw new ArgumentException();

if (span == 0)
    return 1;

foreach (var c in DigitCharArray)
    if (!Char.IsDigit(c))
        throw new ArgumentException();    
```

I seguenti controlli servono per verificare che l'utente abbia inserito correttamente tutti i dati:
- Nel primo if l'algoritmo controlla che la sequenza di numeri non sia maggiore della stringa o che sia minore di 0;
- Nel secono if l'argoritmo controlla che la sequenza di numeri non sia 0;
- Nel foreach e' presente un if che controlla che ogni carattare sia un numero (Digit).

</details>