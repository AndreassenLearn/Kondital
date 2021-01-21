# Kondital
*Bear in mind that this application's interface language is in Danish.*
## Usage
### Input
When the application starts you'll be prompted to enter your weight, resting heart rate, and maximum heart rate one by one.
All values can be entered with or without decimals. Decimals can be indicated with both ',' and '.'.

**Input examples:** `69` `69,21` `69.21` 

If a value is entered incorrectly (for instance with letters in it; `69abc`), you'll be prompted to try again.

### Output
From the entered values the application will calculate your "kondital" and maximum oxygen uptake.

#### Output example:
```
Kondital: 35 ml/kg/min
Maksimal iltoptagelse: 2,6 l/ml
```

## Versions
### v0.1.1
* Added units to output.
* Minor fixes.

### v0.1.0
* Initial version.
* Calculate "kondital" and maximum oxygen uptake.
