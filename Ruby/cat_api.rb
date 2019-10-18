require 'net/http'
require 'openssl'
require 'json'

uri = URI('https://cat-fact.herokuapp.com/facts/random')
req = Net::HTTP::Get.new(uri.path)

res = Net::HTTP.start(
	uri.host, uri.port,
	:use_ssl => uri.scheme == 'https',
	:verify_mode => OpenSSL::SSL::VERIFY_NONE) do |https|
	
		https.request(req)
	
	end
	
results = JSON.parse(res.body)
puts results["text"]
puts results["updatedAt"]