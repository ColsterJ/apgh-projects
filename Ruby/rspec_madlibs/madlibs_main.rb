require './lib/madlibs'

brexit = MadLib.new
puts "Type your very British MadLib story\nWords that you want to be replaced put into curly brackets like {this}"

template = gets.chomp
brexit.process_template(template)

puts "After pressing Enter, pass to another bloke/tte then GUVNAH. GUVNAH!"
gets
system "clear"
system "cls"
puts "Other bloke/tte, fill in the words"

user_words = []
brexit.get_prompts().each_with_index do |prompt, index|
    puts "Give us a #{prompt}"
    user_words[index] = gets.chomp
end

output = brexit.replace(user_words)
system "clear"
system "cls"
puts "\n'ello, guvnah. 'ere's ya story...\n\n#{output}"
