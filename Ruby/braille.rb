# translate message to morse code and print it out
result = ""
# braille["a"][0]  braille["a"][1]

braille = {
    "a"=> [". ",
           "  ",
           "  "],
    "b"=> [". ",". ","  "],
    "c"=> ["..","  ","  "],
    "d"=> [".."," .","  "],
    "e"=> [". "," .","  "],
    "f"=> ["..",". ","  "],
    "g"=> ["..","..","  "],
    "h"=> [". ","..","  "],
    "i"=> [" .",". ","  "],
    "j"=> [" .","..","  "],
    "k"=> [". ","  ",". "],
    "l"=> [". ",". ",". "],
    "m"=> ["..","  ",". "],
    "n"=> [".."," .",". "],
    "o"=> [". "," .",". "],
    "p"=> ["..",". ",". "],
    "q"=> ["..","..",". "],
    "r"=> [". ","..",". "],
    "s"=> [" .",". ",". "],
    "t"=> [" .","..",". "],
    "u"=> [". ","  ",".."],
    "v"=> [". ",". ",".."],
    "w"=> [" .",".."," ."],
    "x"=> ["..","  ",".."],
    "y"=> [".."," .",".."],
    "z"=> [". "," .",".."],
    "."=> ["  ","  ","  "],
    "!"=> ["  ","  ","  "],
    "?" => ["  ","  ","  "],
    " "=> ["  ","  ","  "]
}

# ab
# line = ""
# line += braille["a"][0]
# line += " "
# line += braille["b"][0]
# puts line
puts braille["a"][0] + " " + braille["b"][0]
puts braille["a"][1] + " " + braille["b"][1]
puts braille["a"][2] + " " + braille["b"][2]
# puts braille["a"][2] + " " + braille["b"][2]

# puts "Enter some text: "
# input = gets.chomp.downcase
# chars = input.split('')


# # 

# chars.each do |c|
#     if(morse_code.key?(c))
#        result += morse_code[c]
#     end
# end

# puts "Your message in Braille is: "
# puts "[#{result}]"