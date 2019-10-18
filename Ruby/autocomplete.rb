words = []
File.open("1-1000.txt").each do |line|
    words << line.chomp
end

still_running = true
while still_running
    puts "Enter a word:"
    input = gets.chomp.downcase
    same_word = words.include?(input)

    result = "Did you mean:"
    predictions = 0
    words.each do |word|
        if !same_word && word.start_with?(input) && predictions < 10
            result << "\n  #{word}"
            predictions += 1
        end
    end

    if same_word
        puts "I know that word!"
    elsif predictions > 0
        puts result 
    else
        puts "I don't know that word!"
    end 
    puts "Run again? Y/N"
    answer = gets.chomp.downcase
    if answer == "n"
        puts "Goodbye"
        still_running = false
    end
end