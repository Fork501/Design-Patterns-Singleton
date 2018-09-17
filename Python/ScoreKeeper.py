class ScoreKeeper:

    def __init__(self):
        self.scores = {}

    '''BEGIN Singleton Setup'''
    __instance = None

    @staticmethod
    def get_instance():
        if not ScoreKeeper.__instance:
            ScoreKeeper.__instance = ScoreKeeper()
        return ScoreKeeper.__instance
    '''END Singleton Setup'''

    def increment_score(self, player_name):
        if player_name not in self.scores:
            self.scores[player_name] = 0
        self.scores[player_name] = self.scores[player_name] + 1

    def get_scores(self):
        return self.scores
