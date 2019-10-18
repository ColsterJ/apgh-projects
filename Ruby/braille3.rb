braille = {
    "a"=> ["*.","..",".."],
    "b"=> ["*.","*.",".."],
    "c"=> ["**","..",".."],
    "d"=> ["**",".*",".."],
    "e"=> ["*.",".*",".."],
    "f"=> ["**","*.",".."],
    "g"=> ["**","**",".."],
    "h"=> ["*.","**",".."],
    "i"=> [".*","*.",".."],
    "j"=> [".*","**",".."],
    "k"=> ["*.","..","*."],
    "l"=> ["*.","*.","*."],
    "m"=> ["**","..","*."],
    "n"=> ["**",".*","*."],
    "o"=> ["*.",".*","*."],
    "p"=> ["**","*.","*."],
    "q"=> ["**","**","*."],
    "r"=> ["*.","**","*."],
    "s"=> [".*","*.","*."],
    "t"=> [".*","**","*."],
    "u"=> ["*.","..","**"],
    "v"=> ["*.","*.","**"],
    "w"=> [".*","**",".*"],
    "x"=> ["**","..","**"],
    "y"=> ["**",".*","**"],
    "z"=> ["*.",".*","**"],
    "."=> ["  ","  ","  "],
    "!"=> ["  ","  ","  "],
    "?"=> ["  ","  ","  "],
    " "=> ["  ","  ","  "]
}

console_width = 120
braille_char_width = 3
line_fit = (console_width / braille_char_width) - 5

# Get user message
puts "Enter your message: "
message = gets.chomp.downcase
message = message.sub("'", "")      # remove apostrophes

# Separate string into chunks of (line_fit) characters (i.e. 25 characters)
str_arr = []
counter = 0
which_line = 0
while counter < message.length
    str_arr[which_line] = message[counter,line_fit]
    counter += line_fit
    which_line += 1
end

# Draw lines one string at a time
str_arr.each do |line|
    output_top = ""
    output_mid = ""
    output_bot = ""
    line.each_char do |c|
        output_top << braille[c][0] + " "
        output_mid << braille[c][1] + " "
        output_bot << braille[c][2] + " "
    end
    puts output_top
    puts output_mid
    puts output_bot
    puts ""
    puts ""     # separate vertical rows of braille by two lines
end

# Remind user of message
puts message