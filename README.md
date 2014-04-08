FoCS-Exc
========

Exercise sessions of "Fundamentals of Computer Science" (H04H0B) together with some software to run the simulations.

Content
-------
Exercise sessions:

 1. Finite state machines and regular expressions (March 7)
 2. Context-free grammars (March 21)
 3. Turing machines (April 25)
 4. Graph theory (May 2)
 5. Computational complexity (May 9)

Tests (with solutions):

 1. March 28, 2014 (`toets1-14.tex`)
 2. May 16, 2014 (todo)

Building
--------

### Git?

Without going into detail, git is a subversioning system that allows distributed collaboration.

You can checkout a git repository by installing git:

```
sudo apt-get install git
```

Next you can clone a git repository, for instance this one by running

```
git clone git@github.com:KommuSoft/FoCS-Exc.git
```

### LaTeX?

LaTeX is a language designed to enable a writer to generate all kinds of publications, without having to worry about the typesetting.

In order to convert the documents to a readable format, you need a LaTeX compiler:
```
sudo apt-get install texlive-full
```

You can then generate a pdf by running the LaTeX compiler.

### Makefile

In order to make this more convenient, a `Makefile` has been added to the repository. By running the following command in the directory of the repository:
```
make Fundamentals_of_Computer_Science/exercisesn.pdf
```
Exercise session `n` is generated. You need to replace `n` with a number from `1` to `5` (see list above).

In order to generate all `.pdf` files, run
```
make
```

We advice you to only generate files from the `master` branch since this branch should contain solutions who are at least finished and won't generate compile errors. Although it is still possible some solutions contain small errors (see the section about [contributing](#contributing)).

### Simulators

The repository contains a small simulator for a Turing Machine as well.

You can compile the program by running the following commands:

```
cd Simulators
./configure
make
```

An executable (`Simulators/Simulators/bin/Debug/Simulators.exe`) will be generated. You can run the simulator using `cd` to move to the correct directory and then run:
```
mono Simulators.exe <tmfile>.tm "<inputstring>"
```

for example `mono Simulators.exe test.tm "aaa#aa"` will run a Turing Machine that calculates the addition of the two given unary numbers.

Links
-----
 - Poster about Automata and Computability (dutch): <http://willemvanonsem.ulyssis.be/posterab.pdf>
 - Poster about Fundamentals of Computer Science (work in progress) <http://willemvanonsem.ulyssis.be/posterfocs.pdf>
 - Information about the course: <http://onderwijsaanbod.kuleuven.be/syllabi/v/e/H04H0BE.htm>
 - Course website: <http://people.cs.kuleuven.be/~bart.demoen/FCW/>
 - Automata and Computability Course website: <http://people.cs.kuleuven.be/~bart.demoen/AB/>

Contributing
------------

<img src="http://cdn.shopify.com/s/files/1/0051/4802/products/sticker-small_512x512.jpg?v=1368814207" align="left"/ width="100%" height="*">

Students are welcome to contribute to the repository themselves.

You can do so by "forking" the repository to your own GitHub-account where you can modify your version and then open a pull request to merge your changes into this repository.

Relevant contributions are rewarded by a free GitHub sticker the next exercise session.


Thanks
------

Thanks to:

 - **Thomas Neven**: for reporting a problem with session 1 exercise 8 ([Issue #1](https://github.com/KommuSoft/FoCS-Exc/issues/1)).

License
-------
<a rel="license" href="http://creativecommons.org/licenses/by-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="http://i.creativecommons.org/l/by-sa/4.0/88x31.png" /></a><br /><span xmlns:dct="http://purl.org/dc/terms/" href="http://purl.org/dc/dcmitype/Text" property="dct:title" rel="dct:type">FoCS-Exc</span> by <a xmlns:cc="http://creativecommons.org/ns#" href="https://github.com/KommuSoft/FoCS-Exc" property="cc:attributionName" rel="cc:attributionURL">Willem Van Onsem</a> is licensed under a <a rel="license" href="http://creativecommons.org/licenses/by-sa/4.0/">Creative Commons Attribution-ShareAlike 4.0 International License</a>.
