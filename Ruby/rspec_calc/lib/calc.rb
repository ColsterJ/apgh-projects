class Calculator
    def math(input)
        input = input.chomp.gsub(" ", "")

        pieces = input.split("+")
        if pieces.length == 2
            # checks the pieces to make sure they only contain numbers
            if !(pieces[0] =~ /[0-9]/) || !(pieces[1] =~ /[0-9]/)
                raise "Inputs must be numbers!"
            end

            # correct number of pieces
            num1 = pieces[0].to_f
            num2 = pieces[1].to_f
            answer = num1 + num2
            if answer % 1 == 0      # if it's a whole number (divisible by 1)
                return Integer(answer)  # return it as an integer so it doesn't have .0 at the end
            else
                return answer       # return the number with decimals
            end
        end
    end
end

#     def split_tell(text,separators)
#         separators.each do |sep|
#             if input.split(sep).length > 1
#                 return sep
#             end
#         end
#         return nil
#     end
# end