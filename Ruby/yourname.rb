puts "What is your name?"
name = gets
puts "Your name is " + name

puts "How old are you?"
age = gets.to_i
puts "You are #{age.to_s}  years old"
puts "You'll be #{(age + 5).to_s} in five years"