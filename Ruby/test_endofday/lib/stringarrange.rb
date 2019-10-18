# Hurray, this passes all tests!

class String_Arranger
    # letters should be rearranged in alphabetical order
    # any spaces, punc and numbers should be removed in the output
    # anything uppercase becomes lowercase

    def arrange(text)
        text = text.downcase.chars.sort.join
        # based on:
        # https://solidfoundationwebdev.com/blog/posts/how-to-sort-a-string-alphabetically-in-ruby

        text = text.sub(" ","")
        # replaces spaces with nothing

        output = ""
        text.each_char do |c|
            if letter?(c)   # if it's a letter, add it to output, otherwise ignore it
                output += c
            end
        end

        return output
    end

    def letter?(lookAhead)
        # based on:
        # https://stackoverflow.com/questions/14551256/ruby-how-to-find-out-if-a-character-is-a-letter-or-a-digit
        # this uses a regular expression to check whether the character is within the below ranges
        lookAhead =~ /[A-Za-z]/
    end
end