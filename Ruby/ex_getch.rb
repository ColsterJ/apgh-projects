# Input and screen clearing things!
require "io/console"

input = ""

while input != "q"
    # clear screen for windows
    system "cls"
    # clear screen for OSX/Linux
    system "clear"

    # show last input on screen
    puts input
    puts "(type a 'q' to quit)"

    # get single character input
    input = STDIN.getch
    # character doesn't get typed when a person types it
end
