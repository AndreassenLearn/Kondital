# Kondital
*Bear in mind that this application's interface language is in Danish.*
## Usage
### Input
When the application starts you'll be prompted to enter your gender, age, weight, resting heart rate, and maximum heart rate one by one.
Gender is given by an 'm' for male (*mand*) or a 'k' for female (*kvinde*).
All other values can be entered as a number with or without decimals. Decimals can be indicated with both ',' and '.'.

**Input examples:** `69` `69,21` `69.21` 

If a value is entered incorrectly (for instance with letters in it; `69abc`), you'll be prompted to try again.

### Output
From the entered values the application will calculate your "kondital", maximum oxygen uptake, and your physical health condition.

#### Output example:
```
Kondital: 46 ml/kg/min
Maksimal iltoptagelse: 3,7 l/ml
Kondition: Middel
```

## Versions
### v0.2.0
* Added physical health condition.
* Added README.md.

### v0.1.1
* Added units to output.
* Minor fixes.

### v0.1.0
* Initial version.
* Calculate "kondital" and maximum oxygen uptake.
