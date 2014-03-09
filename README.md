FoCS-Exc
========

Exercise sessions of "Fundamentals of Computer Science".

Content
-------
Exercise sessions:

 1. Finite state machines and regular expressions (March 7)
 2. Context-free grammars (March 21)
 3. Turing machines (April 25)
 4. Graph theory (May 2)
 5. Computational complexity (May 9)

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

In order to make this more convenient, a `Makefile` has been added to the repository. By running the following command in the directory of the repository:
```
make Fundamentals_of_Computer_Science/exercisesn.pdf
```
Exercise session `n` is generated. You need to replace `n` with a number from `1` to `5` (see list above).

In order to generate all `.pdf` files, run
```
make
```

Links
-----
 - Poster about Automata and Computability (dutch): <http://willemvanonsem.ulyssis.be/posterab.pdf>
 - Information about the course: <http://onderwijsaanbod.kuleuven.be/syllabi/v/e/H04H0BE.htm>
