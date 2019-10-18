require "calc"

RSpec.describe Calculator do
    let(:calculator) do
        Calculator.new
        # calculator = Calculator.new
    end

    context "adding numbers" do
        it "adding 2 + 2 with spaces" do
            answer = calculator.math("2 + 2")
            expect(answer).to eql 4
        end
        it "adding 2+2 without spaces" do
            answer = calculator.math("2+2")
            expect(answer).to eql 4
        end
        it "adding 20+255" do
            answer = calculator.math("20+255")
            expect(answer).to eql 275
        end
        it "adding 20.5+255" do
            answer = calculator.math("20+255")
            expect(answer).to eql 275
        end
        it "adding a non-number" do
            expect{calculator.math("a+5")}.to raise_error("Inputs must be numbers!")
        end
    end
end
