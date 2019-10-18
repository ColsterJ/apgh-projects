# message app
# make array to store messages
messages = []
#while loop
#give user 3 options
keep_running = true
while keep_running
    puts "\nWould you like to \n1) store a message,\n2) get a message, \n3) delete a message\n0)or quit?\n"
    input = gets.chomp
    if input == "1"
        puts "\nWhat is your message?\n"
        # messages.each do |message|

        # end
        messages << gets.chomp
        puts messages.length-1
        #for storing messages print message number
        #input = gets.chomp
        #quit option
    elsif input == "2"
        puts "\nWhat is your message ID number?\n"
        begin
            idnumber = gets.chomp
            idnumber = Integer(idnumber)
        rescue ArgumentError
            print "please enter a number\n"
            retry
        end
        if idnumber >= 0 && idnumber < messages.length 
        # if !(messages[idnumber].nil?)   # Thanks Phran
            puts messages[idnumber]     # But he points out it can cause problem if they enter a negative number, since that's a valid index for an array
        else
            puts "\nThat ID number has no message stored in it.\n"
            puts "Think about what you've done..."
            (1..3).each do
                sleep(1)
                puts "keep thinking..."
            end
        end
    elsif input == "3"

    elsif input == "0"
        puts "\nGoodbye!\n"
        keep_running = false
    else
        puts "\nTry again.\n"
    end
end
