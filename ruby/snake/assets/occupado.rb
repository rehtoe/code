class OcupaTile
  attr_accessor :isSolid, :isEdible, :isHealthy, :canKill, :isEmpty
  attr_reader :symbolo, :color

  def initialize()
    @isSolid = false
    @isEdible = false
    @isHealthy = false
    @canKill = false
    @isEmpty = true
  end
  
end
