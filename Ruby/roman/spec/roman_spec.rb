require "converter"

RSpec.describe RomanConverter do
    converter = RomanConverter.new

    it "converts 1 to I" do
        answer = converter.convert(1)
        expect(answer).to eql "I"
    end

    it "converts 2 to II" do
        answer = converter.convert(2)
        expect(answer).to eql "II"
    end

    it "converts 4 to IV" do
        answer = converter.convert(5)
        expect(answer).to eql "V"
    end

    it "converts 5 to V" do
        answer = converter.convert(5)
        expect(answer).to eql "V"
    end

    it "converts 9 to IX" do
        answer = converter.convert(9)
        expect(answer).to eql "IX"
    end

    it "converts 10 to X" do
        answer = converter.convert(10)
        expect(answer).to eql "X"
    end
end