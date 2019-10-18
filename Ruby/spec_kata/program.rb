require './lib/converter'
# ^ if program.rb is outside lib

# require './converter'
# ^ RSpec won't work if converter.rb isn't located in /lib, although program.rb will run with the above if it is located alongside it inside lib

convert = RomanConverter.new
puts "Enter a number to convert: "
number = gets.chomp.to_i
puts convert.convert(number)