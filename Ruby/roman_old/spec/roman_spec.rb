require "converter"

RSpec.describe RomanConverter do
    it "converts 1 to I" do
        converter = RomanConverter.new
        answer = converter.convert(1)
        expect(answer).to eql "I"
    end

    it "converts 2 to II" do
        converter = RomanConverter.new
        answer = converter.convert(2)
        expect(answer).to eql "II"
    end

    it "converts 5 to V" do
        converter = RomanConverter.new
        answer = converter.convert(5)
        expect(answer).to eql "V"
    end
end