
class Tree
  attr_accessor :nodes, :connections

  def initialize()
    @nodes = Array.new
    @connections = Array.new
    n = Node.new
    @n.level(0)
  end

end

class Node
  attr_accessor :identity, :paths, :level

  def initialize()
    @level = 0;
    @paths = Array.new
    @identity = rand(0..999999).to_s
    switch(@identity.length)
      case 1
        @identity = "00000" + @identity
      end
      case 2
        @identity = "0000" + @identity
      end
      case 3
        @identity = "000" + @identity
      end
      case 4
        @identity = "00" + @identity
      end
      case 5
        @identity = "0" + @identity
      end
      case 6

      end
  end

  def level(archLvl)
    @level = archLvl
  end

end

class Sensory < Node

end

class Neural < Node

end

class Action < Node

end

class Connection

end
