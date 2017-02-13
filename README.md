# Akstria
Generates random words with a syllable-based algorithm. The name for this repository was generated with it.
This is an old project from when I first learned how to create forms in C#. The request I was given was simple:
Build a program that randomly creates fictional "words" for the user. The idea behind it was to create large wordlists that the user can look through, picking words to build a fantasy langauge. After proving the concept with a character-by-character algorithm, I designed a syllable-based algoritm to improve the amount of usable words that the program outputs. Below is a description of the current algorithm, organized according to what happens when one of the buttons is pressed.

#Generate
		button1_Click
			String arrays for all syllable types are created, then populated with the contents of their respective text boxes.
			createWords method is called with these arrays and the result of method trackBarSums as parameters
				trackBarSums simple returns the sum of the trackbar values representing the "weights" (or probabilities) of each syllable type.
				The length of words and number of words are stored, and the program enters the main word-generator loop
					While the number of words created is less than the chosen length...
						An empty string 'word' is created,
						While the word is less than the chosen number of syllables...
							A string returned by the method getSyllable is appended to 'word'
								getSyllable parameters call the method pickSyllableType, which calls getProbs to store the weight of each syllable as a percentage
								and also calls getSeed to generate a random number 0-100
									getProbs returns an array of the 11 syllable types weight (its value * 100 / the sum of the trackbar values)
								local_sum is iterated through all 11 syllable types and the selected type is returned when the result of getSeed is less the weight of active syllable type
									inside of getSyllable, empty string 'syllable' is created the syllable type is run through a switch statement
										the switch statement sets the syllable to the element at an index chosen by getSeed from within its respective textbox, as stored in the first step.
							Syllable separator string is appended to 'word'
						'word' is appended to the main textbox along with the word separator string
						And the main textbox is manually updated for each word.
	#Clear
			button2_Click
				The main textbox is cleared, then manually updated

	#Save
			button4_Click
				Basic steps to save the generated wordlist to a file, look this up elsewhere if it's hard to understand

	#Test RNG
			button3_Click
			All trackbars are zeroed out
			For 400 iterations
				A trackbar is chosen randomly with getSeed and has its value incremented
			The weights of these are then displayed in the main textbox (weights should be around 36 +/- ~11)
