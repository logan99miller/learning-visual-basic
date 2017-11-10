Module Module1

    Sub Main()
        Dim sentence, word, replacementStart As String
        sentence = "quick brown fox jumps over the lazy dog"
        While True
            Console.WriteLine("Please enter a word to be extaracted from the sentence: " & sentence)
            word = Console.ReadLine()
            If sentence.Contains(word) Then
                replacementStart = InStr(sentence, word) 'which character in the sentence is the first character of the word

                'Keeps everything left of the character before the word: -1 to ensure it does not keep first letter of word
                ' & everything right of the word: length of sentence - where word starts - rest of word
                sentence = Left(sentence, replacementStart - 1) & Right(sentence, Len(sentence) - replacementStart - Len(word))
            Else
                Console.WriteLine("The sentence does not contain this word :(. Try again")
            End If
        End While
    End Sub

End Module
