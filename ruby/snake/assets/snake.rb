require 'occupado.rb'

class Snake < OcupaTile

  def initialize()
    @isSolid = false
    @isEdible = true
    @isHealthy = false
    @canKill = false
    @isEmpty = false

  end
  
end

class Body < Snake

end
