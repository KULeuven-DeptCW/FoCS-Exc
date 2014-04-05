Simulators
==========

Simulators is a program to simulate Turing machine behavior. The program is entirely written in C#/Mono.

Compiling
---------
In order to compile the program, one needs to install a mono compiler:
```
sudo apt-get install mono-mcs
```

One can then simply compile the programming by running:
```
./configure
make
```
in the current directory. The mono compiler will emit an executable `Simulators` in `Simulators/bin/Debug`.

Running
-------
The program expects two arguments: the name of Turing machine file `*.tm` and an initial string.

For instance:
```
mono Simulators.exe ../../../test.tm "aaa#aa"
```
The program will write the state of the Turing machine to the standard output (`stdout`) and wait until the user
presses enter.

One can terminate the program by pressing `Ctrl+C`.

Turing machine file
-------------------
A Turing machine file is structured in states. One writes a file that is structured as follows:
```
State q0
  a/q0/a/R
  #/q1/a/R
State q1
  a/q1/a/R
  _/q2/_/L
State q2
  a/q3/_/L
State q3!
```

The file is divided into states. One uses the `State` keyword followed by the name of the state. If the state is accepting, an exclamation mark (`!`) is added as well.

Each state item contains a list of transitions. A transition consists of four items separated by a slash (`/`):

 - The first item is the original character that should be placed under the Turing machines head;
 - the second item is the next state of the Turing machine;
 - The third item is the new character that will be written over the original character;
 - The fifth item is `L` (left), `R` (right) or `S` (stay) that specifies the direction in which the Turing machines head will move.

Lines that cannot be interpreted by the parser correctly are ignored.
