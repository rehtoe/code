require '/run/media/r/p0/code/ruby/API/sort/KeyStream.rb'

class GameEngine

  attr_reader :gengINP

  def initialize
    @gengINP = KeyStream.new("e")
  end

end
