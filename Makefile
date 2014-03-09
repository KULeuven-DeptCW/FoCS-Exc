all :
	make "Fundamentals_of_Computer_Science/exercises1.pdf"
	make "Fundamentals_of_Computer_Science/exercises2.pdf"
	make "Fundamentals_of_Computer_Science/exercises3.pdf"
	make "Fundamentals_of_Computer_Science/exercises4.pdf"
	make "Fundamentals_of_Computer_Science/exercises5.pdf"
%.pdf: %.tex
	bash makepdf.sh $<
%.txt: %.tex
	bash maketext.sh $<
