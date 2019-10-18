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
    "*"=> ["  ","  ","  "],
    "!"=> ["  ","  ","  "],
    "?"=> ["  ","  ","  "],
    " "=> ["  ","  ","  "]
}

console_width = 80
braille_char_width = 3
line_fit = (console_width / braille_char_width)  # how many braille characters fit on a line
# line_fit = 3   # try 3 to see it working without long AF strings

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
    # puts str_arr[which_line]          # just for testing
    which_line += 1
end

# Draw lines one string at a time
str_arr.each do |line|
    line.each_char do |c|
        print braille[c][0] + " "
    end
    puts ""
    line.each_char do |c|
        print braille[c][1] + " "
    end
    puts ""
    line.each_char do |c|
        print braille[c][2] + " "
    end 
    puts ""
    puts ""     # separate vertical rows of braille by two lines
end

# Remind user of message
puts message
