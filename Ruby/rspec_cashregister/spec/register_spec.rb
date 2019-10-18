require 'register'

describe CashRegister do

    before(:all) do
        @register = CashRegister.new
    end

    context "gives $20" do
        it "change for $4.53 is -- 1 ten dollar bill, 1 five dollar bill, 1 quarter, 2 dimes, 2 pennies" do
            change = @register.change(4.53, 20)
            expect(change).to eql("1 ten dollar bill, 1 five dollar bill, 1 quarter, 2 dimes, 2 pennies")
        end
        it "change for $.49 is -- 1 ten dollar bill, 1 five dollar bill, 4 one dollar bills, 2 quarters, 1 penny" do
            change = @register.change(0.49, 20)
            expect(change).to eql("1 ten dollar bill, 1 five dollar bill, 4 one dollar bills, 2 quarters, 1 penny")
        end
        it "change for the devil is..." do
            expect{@register.change("the devil", 20)}.to raise_error("Invalid Input, dumdum")
        end
        it "change ends in a 3, so denominations should be chosen randomly" do
            change = @register.change(0.47, 20)
            expect(change).not_to eql("1 ten dollar bill, 1 five dollar bill, 4 one dollar bills, 2 quarters, 3 pennies")
        end
    end
end
