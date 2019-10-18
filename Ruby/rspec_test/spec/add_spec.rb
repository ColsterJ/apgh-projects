require "add"

RSpec.describe Adder do
    let(:adder) do
        Adder.new
    end

    it "gives 2 for 1+1" do
        answer = adder.add(1,1)
        expect(answer).to eql 2
    end

    it "gives 54 for 49+5" do
        answer = adder.add(49,5)
        expect(answer).to eql 54
    end

    it "gives 101.9 for 99+2.9" do
        answer = adder.add(99,2.9)
        expect(answer).to eql 101.9
    end
end