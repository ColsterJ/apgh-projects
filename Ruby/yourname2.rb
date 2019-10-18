puts "What is your name?"
name = gets
puts "Your name is " + name
if name.upcase.include? "O"
    puts "Your name contains an 'o'"
end
if name.upcase["A"]     # This also works!? What? I guess it's finding index of "A"? array brackets can be weird in Ruby
    puts "Your name contains an 'a'"        # Jean says it's not idiomatic Ruby and the include? is better
end
if name.length > 10
    puts "Your name is over 10 characters long"
end

puts "How old are you?"
age = gets.to_i
puts "You are #{age} years old"
puts "You'll be #{age + 5} in five years"