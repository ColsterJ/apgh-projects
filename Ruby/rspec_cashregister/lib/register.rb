require 'bigdecimal/util'

class CashRegister
    def change(cost, paid)
        if !(paid.is_a? Numeric) || !(cost.is_a? Numeric)
            raise "Invalid Input, dumdum"
        end

        change = (paid.to_d - cost.to_d).to_d
        if change.truncate(2).to_s('F').end_with? "3"
            set_denominations_randomly()
            # puts "doing random change"
            # puts @denominations
        else
            # puts "not doing random change"
            set_denominations_normal()
        end
        result = ""
        @denominations.each do |denomination|
            tally = 0
            while change >= denomination[:value]
                change -= denomination[:value]
                tally += 1
            end
            if tally > 0
                if tally > 1
                    result += "#{tally} #{denomination[:name]}s" 
                else
                    result += "#{tally} #{denomination[:name]}" 
                end
                if result != "" && change != 0
                    result += ", "
                end
            end
        end

        result = result.gsub("pennys", "pennies")

        # puts result
        return result
    end

    def initialize
        set_denominations_normal()
    end

    def set_denominations_normal
        @denominations = []

        add_denomination("hundred dollar bill", 100)
        add_denomination("fifty dollar bill", 50)
        add_denomination("twenty dollar bill", 20)
        add_denomination("ten dollar bill", 10)
        add_denomination("five dollar bill", 5)
        add_denomination("one dollar bill", 1)
        add_denomination("quarter", 0.25)
        add_denomination("dime", 0.10)
        add_denomination("nickel", 0.05)
        add_denomination("penny", 0.01)
    end

    def set_denominations_randomly
        # new_denominations = []
        # counter = 0

        # @denominations.each do |denom|
        #     rand_index = rand(@denominations.length)
        #     while new_denominations[rand_index]
        #         rand_index = rand(@denominations.length)
        #     end
        #     new_denominations[counter] = denom
        #     counter += 1
        # end

        # puts new_denominations

        new_array = @denominations      # they start equal
        while new_array == @denominations   # while they're equal
            new_array = @denominations.shuffle  # try to get a randomized set
        end

        @denominations = new_array
    end

    def add_denomination(name, value)
        @denominations << {name: name, value: value}
    end
end


register = CashRegister.new
# register.change(0.47, 20)
(1..100).each do
    register.change(0.47, 20)
end
