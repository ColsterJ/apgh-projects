# translate message to morse code and print it out
result = ""
morse_code = {
    "a"=> ".- ",
 "b"=> "-... ",
 "c"=> "-.-. ",
 "d"=> "-.. ",
 "e"=> ". ",
 "f"=> "..-. ",
 "g"=> "--. ",
 "h"=> ".... ",
 "i"=> ".. ",
 "j"=> ".--- ",
 "k"=> "-.- ",
 "l"=> ".-.. ",
 "m"=> "-- ",
 "n"=> "-. ",
 "o"=> "--- ",
 "p"=> ".--. ",
 "q"=> "--.- ",
 "r"=> ".-. ",
 "s"=> "... ",
 "t"=> "- ",
 "u"=> "..- ",
 "v"=> "...- ",
 "w"=> ".-- ",
 "x"=> "-..- ",
 "y"=> "-.-- ",
 "z"=> "--.. ",
 "." => " ",
 "!" => " ",
 "?" => " ",
 " "=> " "
}

puts "Enter some text: "
input = gets.chomp.downcase
chars = input.split('')

chars.each do |c|
    if(morse_code.key?(c))
       result += morse_code[c]
    end
end

puts "Your message in Morse code is: "
puts "[#{result}]"