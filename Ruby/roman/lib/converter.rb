# XL - 40, L - 50, XC - 90, C - 100

class RomanConverter
    def convert(user_input)
        output = ""
        while(user_input >= 50)
            output += "L"
            user_input -= 50
        end
        while(user_input >= 40)
            output += "XL"
            user_input -= 40
        end
        while(user_input >= 10)
            output += "X"
            user_input -= 10
        end
        while(user_input >= 9)
            output += "IX"
            user_input -= 9
        end
        while(user_input >= 5)
            output += "V"
            user_input -= 5
        end
        while(user_input >= 4)
            output += "IV"
            user_input -= 4
        end
        while(user_input >= 1)
            output += "I"
            user_input -= 1
        end
        return output
    end
end