class Translator
    def initialize
        @morse_code = {"a" => ".--- "}
    end

    def translate(input)
        output = ""
        chars = input.split("")

        chars.each do |c|
            output += @morse_code[c]
        end

        return output
    end
end

translator = Translator.new
puts translator.translate("aaa")